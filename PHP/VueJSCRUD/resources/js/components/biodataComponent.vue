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
                    <th> </th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="biodata in biodatas"  >
                    <td>{{biodata.name}}</td>
                    <td>{{biodata.email}}</td>
                    <td><button class="btn btn-success" @click="getEdit(biodata)" :disabled="biodata.statusEdit">Edit</button></td>
                     <td><button class="btn btn-danger" @click="deleted(biodata.id)" >Delete</button></td>
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
                email:'',
                statusEdit : false
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
            this.biodata.statusEdit = false;
            this.biodata = data;
            this.editStatus = true;
            Object.assign( this.biodataEdit  ,  data );
            data.statusEdit = true;
            
        },
        updateBiodata(){
            axios.patch('/biodata/'+ this.biodataEdit.id , this.biodataEdit).then(response=>{
                let bio =  response.data.biodata;
                this.biodata.email =  bio.email;
                this.biodata.name =  bio.name;

                this.biodata.statusEdit = false;
                this.editStatus = false;

                this.biodataEdit ={
                    name : '',
                    email :''
                }
                this.biodata = {
                    email :'',
                    name : '',
                    statusEdit : false
                };
                
            });
        },
        cancelEdit(){
            this.biodata.statusEdit = false;
            this.editStatus = false;
            this.biodataEdit = {
                email :'',
                name : ''
            };
            this.biodata = {
                email :'',
                name : '',
                statusEdit : false
            };
        },
        deleted(id){
            let data = this.biodatas;
            axios.delete('/biodata/'+ id   ).then(response=>{
                if( response.status == 200){
                    data.forEach(function(element,index,value){
                        if( element.id == id ){
                            data.splice(index,1);
                        }
                    });
                }
                 
            });
        }
    }
}
</script>