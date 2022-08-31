import React from 'react'
import {useEffect,useState} from 'react'
import axios from 'axios'
import {Form, Button} from "react-bootstrap"
import 'bootstrap/dist/css/bootstrap.min.css';
import './Login.css'

function Login() {
    const [user, setUser] = useState({
        username: '',
        password: ''
    })
    const createUser = () => {
        axios
          .post("http://localhost:5000/users", user)
          .then(res => {window.location.reload(false)})
          .catch(err => console.error(err));
    }
    return (
        <div className="Login">
            <div id="jumb">
                <h1>Log In</h1>
                <p>Enter your Email & Password.</p>
            </div>
            <Form>
                <Form.Group className="mb-3" controlId="formBasicEmail">
                    <Form.Label>Email address</Form.Label>
                    <Form.Control type="email" placeholder="Enter email" value={user.username} onChange={(event) => {
                        setUser({...user,username:event.target.value})
                    }}/>
                    <Form.Text className="text-muted">
                    We'll never share your email with anyone else.
                    </Form.Text>
                </Form.Group>

                <Form.Group className="mb-3" controlId="formBasicPassword">
                    <Form.Label>Password</Form.Label>
                    <Form.Control type="password" placeholder="Password" value={user.password} onChange={(event) => {
                        setUser({...user,password:event.target.value})
                    }}/>
                </Form.Group>
                <Form.Group className="mb-3" controlId="formBasicCheckbox">
                    <Form.Check type="checkbox" label="Check me out" />
                </Form.Group>
                <Button variant="primary" type="submit" onClick={createUser}>
                    Submit
                </Button>
            </Form>
        </div>
    )
}

export default Login
