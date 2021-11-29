import React, {useState} from 'react'
import {Form, Button} from "react-bootstrap"
import axios from 'axios'
import 'bootstrap/dist/css/bootstrap.min.css';

function Login() {
    const [user,setUser] = useState({
        username: "",
        password: ""
    })
    const submitUser = () =>{
        axios.post('http://localhost:5000/users', user).then(() => {
            window.location.reload(false);
        })
    }
    return (
        <>
            <div className="container">
                <div id="jumbLogin">
                    <h1>Log In</h1>
                    <p>Enter your Email & Password.</p>
                </div>
            </div>
            <div className="container">
            <Form>
                <Form.Group className="mb-3" controlId="formBasicEmail">
                    <Form.Label>Email address</Form.Label>
                    <Form.Control type="email" placeholder="Enter email" value={user.username} onChange={(event) => {
                        setUser({...user,username: event.target.value})
                    }}/>
                    <Form.Text className="text-muted">
                    We'll never share your email with anyone else.
                    </Form.Text>
                </Form.Group>

                <Form.Group className="mb-3" controlId="formBasicPassword">
                    <Form.Label>Password</Form.Label>
                    <Form.Control type="password" placeholder="Password" value={user.password} onChange={(event) => {
                        setUser({...user,password: event.target.value})
                    }}/>
                </Form.Group>
                <Form.Group className="mb-3" controlId="formBasicCheckbox">
                    <Form.Check type="checkbox" label="Check me out" />
                </Form.Group>
                <Button variant="primary" type="submit" onClick={submitUser}>
                    Submit
                </Button>
            </Form>
            </div>
        </>
    )
}

export default Login
