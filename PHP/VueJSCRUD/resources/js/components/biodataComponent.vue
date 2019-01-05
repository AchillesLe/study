<template>
    <div>
        <form @submit.prevent="createBiodata" type="post" v-show="!editStatus">
            <div class="form-group">
                <input type="text" class="form-control" id="name" v-model="biodata.name" placeholder="name">
            </div>
            <div class="form-group">
                <input type="text"  class="form-control" id="email" v-model="biodata.email" placeholder="email">
            </div>
             <div class="form-group">
                <button type="submit" class="btn btn-info" >create</button>
            </div>
        </form>
        <form @submit.prevent="updateBiodata" type="post" v-show="editStatus">
            <div class="form-group">
                <input type="text"  class="form-control" id="name" v-model="biodataEdit.name" placeholder="name">
            </div>
            <div class="form-group">
                <input type="text"   class="form-control" id="email" v-model="biodataEdit.email" placeholder="email">
            </div>
             <div class="form-group">
                <button type="submit" class="btn btn-info" >save</button>
                <button type="button" class="btn btn-warning" @click="cancelEdit">cancel</button>
            </div>
        </form>
        <table class="table table-hover">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th> </th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="biodata in biodatas"  >
                    <td>{{biodata.name}}</td>
                    <td>{{biodata.email}}</td>
                    <td><button class="btn btn-success" @click="getEdit(biodata)">Edit</button></td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
export default {
    
    data(){
        return {
            biodata:{
                name:'',
                email:''
            },
            biodatas: [],
            editStatus : false ,
            biodataEdit:{
                name:'',
                email:''
            },
        };
    },
    created() {
        this.fecthBiodata()
    },
    methods:{
        fecthBiodata(){
            axios.get('/biodata').then(respone=>{
                this.biodatas = respone.data.data;
                console.log(this.biodatas);
            });
        },
        createBiodata(){
            axios.post('/biodata',this.biodata).then(response=>{
                this.biodatas.push(response.data.biodata);
                this.biodata = {
                    name : '',
                    email :''
                }
            });
        },
        getEdit(data){
            this.editStatus = true;
            this.biodataEdit = data;
        },
        editBiodata(){
            axios.patch('/biodata'+biodata.id , this.biodataEdit).then(response=>{
                let bio = response.data.biodata;

                $$.each( this.biodatas , function(key, value) {
                    console.log(this.biodatas[key]);
                });

                this.biodatas.push(response.data.biodata);
                this.biodataEdit ={
                    name : '',
                    email :''
                }
            });
        },
        cancelEdit(){
            this.editStatus = false;
            this.biodataEdit = {
                email :'',
                name : ''
            };
        }
    }
}
</script>