<teamplate>
    <div>
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="biodata in biodatas" :key="biodata.key">
                    <td>{{biodata.name}}</td>
                    <td>{{biodata.email}}</td>
                </tr>
            </tbody>
        </table>
    </div>
</teamplate>
<script>
export default {
    data(){
        return {
            biodatas: []
        };
    },
    created() {
        this.fecthBiodata()
    },
    methods:{
        fecthBiodata(){
            axios.get('/biodata').then(respone=>{
                this.biodatas = respone.data.biodata
            });
        }
    }
}
</script>