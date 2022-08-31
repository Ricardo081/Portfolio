import React from 'react'
import './Left_Container.css'
import {BrowserRouter as Router, Routes, Route, Link} from 'react-router-dom'
import Texas_Pick from '../mid_container/Texas_Pick'
import Breakfast from '../mid_container/Breakfast'
import Lunch from '../mid_container/Lunch'
import Dinner from '../mid_container/Dinner'

function Left_Container() {
    return (
        <Router>
            <div className="Left_Container">
                <div id="menuTimes">
                    <Link to="/"><button>Texas' Pick</button></Link>
                    <Link to="/Traditional"><button>Traditional</button></Link>
                    <Link to="/Cakes"><button>Cakes</button></Link>
                    <Link to="/Sweets"><button>Sweets</button></Link>
                </div>
            </div>
            <Routes>
                <Route path="/" element={<Texas_Pick/>} />
                <Route path="/Traditional" element={<Breakfast/>} />
                <Route path="/Cakes" element={<Lunch/>} />
                <Route path="/Sweets" element={<Dinner/>} />
                
            </Routes>
        </Router>
    )
}

export default Left_Container
