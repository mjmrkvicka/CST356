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
            <p>CST 356 - Lab 7</p>
        </div>
    </body>
    </html>
    </div>
</template>

<script>
    import Vue from 'vue'

    export default {
        name: 'Persons',
        props: ['auth'],

        data () {
            return {
                persons: []
            }
        },
        methods: {

            getAuthHeader: function() {
                return {
                    headers: {
                        Authorization: 'Bearer ' + this.auth.accessToken
                    }
                }
            },

            getPersons: function() {
                let personsApi = 'http://localhost:5000/api/persons';

                Vue.axios.get(personsApi, this.getAuthHeader())
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