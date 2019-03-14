<template>
    <div>
    <html>
    <body>

        <h1>Login</h1>

        <form>
            <div class="form-entry">
            <input 
                type="text" 
                placeholder="Username"
                v-model="userName">
            </div>
            <div class="error">{{ userNameError }}</div>
            <br>

            <div class="form-entry">
            <input 
                type="text"
                placeholder="Password"
                v-model="password">
            </div>
            <div class="error">{{ pwdError }}</div>
            <br>

            <div class="form-entry">
            <input 
                type='button' 
                value='Login' 
                v-on:click='submitLogin'/>
            </div>
        </form>
    </body>
    </html>    
    </div>
</template>

<script>
    export default {
        name: 'Login',
        methods: {
            submitLogin: function() {
                if (this.userName.length == 0) {
                    this.userNameError = "Please enter a username";
                }
                if (this.password.length == 0) {
                    this.pwdError = "Please enter a password";
                }  
                return;     
            }
        },
        data () {
            return {
                userName: '',
                password: '',
                userNameError: '',
                pwdError: '',
            }
        }   
    }
</script>

<style>
</style>