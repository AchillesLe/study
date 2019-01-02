
class Welcome extends React.Component {
    constructor(props) {
        super(props);
        this.state = {date: new Date()};
        this.thongtin = this.thongtin.bind(this)
    }
    render() {
        return (
            <div>
                <h1>{this.props.name}</h1>
                <button onClick={this.thongtin} >click vao day</button>
            </div>
        );
    }
    thongtin () {
        alert(this.props.children)
    }

}

ReactDOM.render( 
    <Welcome name="EEEE">XAAAAA</Welcome>,
document.getElementById('root'));