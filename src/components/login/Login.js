import React, {Component} from "react";
import axios from "axios";
import './Login.css';
export default class Login extends Component{
    constructor(props){
        super(props);
this.state={
    email:"",
    password:"",
    loginErrors:""
}
this.handleSubmit=this.handleSubmit.bind(this);
this.handleChange=this.handleChange.bind(this);
    };
        handleChange(event){
            this.setState({
                [event.target.name]: event.target.value
            });
           
        }
        handleSubmit(event){
            const {email,password} =this.state;
            
           var consss= axios.get('http://employeecrud.azurewebsites.net/api/values/GetAllEmployees');
            
                 
              
                    console.log("Hi");
               
           
        }
        render()
        {
            return(
                <div class="Login">  
                 <h1>Login Here</h1>
                    <form onSubmit={this.handleSubmit}>
                    <p>Username</p>
                    <input 
                    type="email"
                    name="email"
                    placeholder="Email"
                    value={this.state.email}
                    onChange={this.handleChange}
                    required
                    />
                     <p>Password</p>
                     <input 
                    type="password"
                    name="password"
                    placeholder="Password"
                    value={this.state.password}
                    onChange={this.handleChange}
                    required
                    />
                    <button type="sumbit">Login</button>
                    </form>

                </div>
            )
        }
}