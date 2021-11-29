import React from 'react'
import './App.css'
import Head from './components/head/Head'
import Left_Panel from './components/body/Left_Panel'
import Menu from './components/body/Menu'
import Right_Panel from './components/body/Right_Panel'
import NavFoot from './components/foot/NavFoot'

function App() {
  return (
    <div className='App'>
      {/* Head */}
      <Head/>
      {/* Body */}
      <Left_Panel/>
      <Menu/>
      <Right_Panel/>
      {/* Foot */}
      <NavFoot/>
    </div>
  )
}

export default App
