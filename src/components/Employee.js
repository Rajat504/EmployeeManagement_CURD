import react,{component} from react
import {Model,Button,Row,Coloumn,Form} from 'react-bootstrap';
import axios from axios;

export class  AddEmployee extends component{
    constructor(props){
        super (props)
        this.state={
            FirstName:'',
            LastName:'',
            EmailId:'',
            Password:'',
            MobileNo:'',
            snackbaropen:false,snackbarmsg:''
        };
        this.handleSubmit=this.handleSubmit.bind(this);
    
    changeHandler = event=>{
        this.setstate({[event.target.name]:event.target.value})
    }
    handleSubmit=event=>{
        event.preventDefault()
        console.log(this.state)
        render()
        {
            const { fullName, email, password,mobile,address} = this.state
            return(
                <div className="container">
                    <Snackbar 
                        anchorOrigin={{vertical:'bottom',horizontal:'bottom'}}
                        open = {this.state.snackbaropen}
                        action=
                        {[
                            <IconButton
                                key="close"
                                arial-label="close"
                                color="inherit"
                                onClick={this.snackbarClose}
                            >
                            x
                            </IconButton>
                        ]}
              )  } 
        }
    }
}
