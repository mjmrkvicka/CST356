<template>
  <div id="app">
    <Navbar></Navbar>
    <router-view/>
  </div>
</template>

<script>
    import Navbar from './components/Navbar.vue';

    export default {
        name: 'App',
        components: { Navbar },
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

    .error {
        color: red;
        font-size: 12px;
    }

</style>
