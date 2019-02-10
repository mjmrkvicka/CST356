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

    export default {
        name: 'Students',
        mounted () {
            this.students = getStudents();
        },
        data () {
            return {
                students: []
            }
        }
    }

    function getStudents() {
        return testStudents.students;
    }

    var testStudents = {'students': [
        {'id': 12958073, 'email':'student1@oit.edu'},
        {'id': 78463720, 'email':'student2@oit.edu'},
        {'id': 90128473, 'email':'student3@oit.edu'},
        {'id': 39872048, 'email':'student4@oit.edu'},
        {'id': 98759473, 'email':'student5@oit.edu'},
    ]};

</script>

<style>
</style>