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
                    <Link to="/breakfast"><button>Breakfast</button></Link>
                    <Link to="/lunch"><button>Lunch</button></Link>
                    <Link to="/dinner"><button>Dinner</button></Link>
                </div>
            </div>
            <Routes>
                <Route path="/" element={<Texas_Pick/>} />
                <Route path="/breakfast" element={<Breakfast/>} />
                <Route path="/lunch" element={<Lunch/>} />
                <Route path="/dinner" element={<Dinner/>} />
                
            </Routes>
        </Router>
    )
}

export default Left_Container
