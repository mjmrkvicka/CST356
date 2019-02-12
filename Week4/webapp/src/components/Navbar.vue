<template>
  <div>
    <nav>
        <ul>
            <li><span v-on:click='goToHome'>Home</span></li>
            <li><span v-on:click='goToPersons'>Persons</span></li>
            <li><span v-on:click='goToStudents'>Students</span></li>
            <li><span v-on:click='goToLogin'>Logout</span></li>
        </ul>
    </nav>  
  </div>
</template>

<script>
    export default {
    name: 'Navbar',
    methods: {
        goToHome: function() {
            this.$router.push({ path: 'home' })
        },
        goToPersons: function() {
            this.$router.push({ path: 'persons' })
        },
        goToStudents: function() {
            this.$router.push({ path: 'students' })
        },
        goToLogin: function() {
            this.$router.push({ path: 'login'})
        }
    }
    }
</script>

<style scoped>

    ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        overflow: hidden;
        background-color: darkgreen;
    }

    li {
        float: left;
        display: block;
        padding: 12px;
        color: white;
        text-decoration: none;
        cursor: pointer;
    }

    li:hover {
        background-color: darkslategray;
    }

</style>
