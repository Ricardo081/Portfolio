import React from 'react'
import {BrowserRouter as Router, Routes, Route, Link} from 'react-router-dom'//npm i react-router-dom@6
import "../App.css"
import ErrorPage from './ErrorPage'
import Home from './Home'
import Login from './Login'

function NavBar() {
    return (
        <Router>
            <div id="nav">
                <ul>
                    <li id="aTitle"><Link to="/home">Eddytors</Link></li>
                    <li id="aHome"><Link to="/home">Home</Link></li>
                    <li id="aLogin"><Link to="/login">Login</Link></li>
                </ul>
            </div>
            <Routes>
                <Route path="/" element={<Home/>} />
                <Route path="/home" element={<Home/>} />
                <Route path="/login" element={<Login/>} />
                <Route path="*" element={<ErrorPage/>} />
            </Routes>
        </Router>
    )
}

export default NavBar
