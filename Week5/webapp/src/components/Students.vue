<template>
    <div>
    <html>
    <body>

        <h1>Students</h1>

        <table>
            <thead>
                <tr>
                    <th>Student ID</th>
                    <th>Email</th> 
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students">
                    <td>{{ student.id }}</td>
                    <td>{{ student.email }}</td>
                </tr>
            </tbody>
        </table>

        <div class="footer">
            <p>CST 356 - Lab 4</p>
        </div>
    </body>
    </html> 
    </div>
</template>

<script>
    import Vue from 'vue'

    export default {
        name: 'Students',
        data () {
            return {
                students: []
            }
        },
        methods: {
            getStudents: function() {
                let studentsApi = 'http://localhost:8081/api/students';

                Vue.axios.get(studentsApi)
                .then(
                    (response) => {
                        console.log(response);
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error);
                    }
                )
            }
        },
        mounted () {
            this.getStudents();
        }
    }

</script>

<style>
</style>