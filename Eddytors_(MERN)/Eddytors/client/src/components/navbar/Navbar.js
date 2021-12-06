import React from 'react'
import {BrowserRouter as Router, Routes, Route, Link} from 'react-router-dom'
import Error_Page from '../../pages/error_page/Error_Page'
import Home from '../../pages/home/Home'
import Login from '../../pages/login/Login'
import './Navbar.css'

function Navbar() {
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
                <Route path="*" element={<Error_Page/>} />
            </Routes>
        </Router>
    )
}

export default Navbar
