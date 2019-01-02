//Biến toàn cục
var http_arr = new Array();
 
function doUpload() {
    document.getElementById('progress-group').innerHTML = ''; //Reset lại Progress-group
    var files = document.getElementById('myfile').files; 
    for ( i=0; i < files.length ; i++ ) {
        uploadFile(files[i], i);
    }
    return false;
}
 
function uploadFile(file, index) {
    var http = new XMLHttpRequest();
    console.log(http);

    http_arr.push(http);
    /** Khởi tạo vùng tiến trình **/

    var ProgressGroup = document.getElementById('progress-group');

    var Progress = document.createElement('div');
    Progress.className = 'progress';

    var ProgressBar = document.createElement('div');
    ProgressBar.className = 'progress-bar';

    var ProgressText = document.createElement('div');
    ProgressText.className = 'progress-text';   

    Progress.appendChild(ProgressBar);
    Progress.appendChild(ProgressText);
 
    ProgressGroup.appendChild(Progress);
 
 
    //Biến hỗ trợ tính toán tốc độ
    var oldLoaded = 0;
    var oldTime = 0;
    //Sự kiện bắt tiến trình
    http.upload.addEventListener('progress', function(event) {  
        console.log(event);
        if ( oldTime == 0 ) { //Set thời gian trước đó nếu như bằng không.
            oldTime = event.timeStamp;
        }   
        //Khởi tạo các biến cần thiết
        var fileName = file.name; //Tên file
        var fileLoaded = event.loaded; //Đã load được bao nhiêu
        var fileTotal = event.total; //Tổng cộng dung lượng cần load
        var fileProgress = parseInt( (fileLoaded/fileTotal)*100 ) || 0; //Tiến trình xử lý
        var speed = speedRate(oldTime, event.timeStamp, oldLoaded, event.loaded);
        //Sử dụng biến
        ProgressBar.innerHTML = fileName + ' đang được upload...';
        ProgressBar.style.width = fileProgress + '%';
        ProgressText.innerHTML = fileProgress + '% Upload Speed: '+speed+'KB/s';
        //Chờ dữ liệu trả về
        if (fileProgress == 100) {
            ProgressBar.style.background = 'url("../images/progressbar.gif")';
        }
        oldTime = event.timeStamp; //Set thời gian sau khi thực hiện xử lý
        oldLoaded = event.loaded; //Set dữ liệu đã nhận được
    }, false);
     
 
    //Bắt đầu Upload
    var data = new FormData();
    data.append('filename', file.name);
    data.append('myfile', file);
    http.open('POST', 'server/upload.php', true);
    http.send(data);
    console.log(data);
 
    //Nhận dữ liệu trả về
    http.onreadystatechange = function(event) {
        //Kiểm tra điều kiện
        if (http.readyState == 4 && http.status == 200) {
            ProgressBar.style.background = ''; //Bỏ hình ảnh xử lý
            try { //Bẫy lỗi JSON
                var server = JSON.parse(http.responseText);
                if (server.status) {
                    ProgressBar.className += ' progress-bar-success'; //Thêm class Success
                    ProgressBar.innerHTML = server.message; //Thông báo             
                } else {
                    ProgressBar.className += ' progress-bar-danger'; //Thêm class Danger
                    ProgressBar.innerHTML = server.message; //Thông báo
                }
            } catch (e) {
                ProgressBar.className += ' progress-bar-danger'; //Thêm class Danger
                ProgressBar.innerHTML = 'Có lỗi xảy ra'; //Thông báo
            }
        }
        http.removeEventListener('progress',null); //Bỏ bắt sự kiện
    }
}
 
function cancleUpload() {
    for ( i=0 ; i < http_arr.length ; i++) {
        http_arr[i].removeEventListener('progress',null);
        http_arr[i].abort();
    }
    var ProgressBar = document.getElementsByClassName('progress-bar');
    for ( i=0 ; i < ProgressBar.length; i++) {
        ProgressBar[i].className = 'progress progress-bar progress-bar-danger';
    }   
}
 
 
function speedRate(oldTime, newTime, oldLoaded, newLoaded) {
        var timeProcess = newTime - oldTime; //Độ trễ giữa 2 lần gọi sự kiện
        if (timeProcess != 0) {
            var currentLoadedPerMilisecond = (newLoaded - oldLoaded)/timeProcess; // Số byte chuyển được 1 Mili giây
            return parseInt((currentLoadedPerMilisecond * 1000)/1024); //Trả về giá trị tốc độ KB/s
        } else {
            return parseInt(newLoaded/1024); //Trả về giá trị tốc độ KB/s
        }
}