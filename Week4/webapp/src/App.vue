<template>
  <div id="app">
    <nav>
        <ul>
            <li><span v-on:click='goToHome'>Home</span></li>
            <li><span v-on:click='goToPersons'>Persons</span></li>
            <li><span v-on:click='goToStudents'>Students</span></li>
        </ul>
    </nav>  
    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App',
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
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}

body {
    font-family: Arial;
}

#homeHeader {
    color: orangered;
    position: relative;
}

#homeHeader img {
    vertical-align: middle;
    width: 40px;
    height: 40px;
}

h1, h3 {
    color: darkslategray;
}

.footer {
    position: fixed;
    left: 0;
    bottom: 0;
    width: 100%;
    background-color: gray;
    color: white;
    text-align: center;
}

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

table {
    border-collapse: collapse;
}

th {
    color: white;
    background-color: darkslategray;
}

th, td {
    padding: 5px 10px 5px 10px;
}

tr:nth-child(odd){background-color: rgb(228, 228, 228)}

</style>
