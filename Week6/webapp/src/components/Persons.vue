<template>
    <div>

    <html>

    <body>

        <h1>Persons</h1>

        <table>
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Middle Initial</th>
                    <th>Last Name</th> 
                </tr>
            </thead>
            <tbody>
                <tr v-for="person in persons">
                    <td>{{ person.firstName }}</td>
                    <td>{{ person.middleName }}</td>
                    <td>{{ person.lastName }}</td>
                </tr>
            </tbody>
        </table>

        <div class="footer">
            <p>CST 356 - Lab 6</p>
        </div>
    </body>
    </html>
    </div>
</template>

<script>
    import Vue from 'vue'

    export default {
        name: 'Persons',
        data () {
            return {
                persons: []
            }
        },
        methods: {
            getPersons: function() {
                let personsApi = 'http://localhost:8081/api/persons';

                Vue.axios.get(personsApi)
                .then(
                    (response) => {
                        console.log(response);
                        this.persons = response.data;
                    },
                    (error) => {
                        console.log(error);
                    }
                )
            }
        },
        mounted () {
            this.getPersons();
        }
    }
</script>

<style>
</style>