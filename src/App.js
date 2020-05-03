import React from 'react';
import {BrowserRouter, Switch, Route} from "react-router-dom";
import logo from './logo.svg';
import './App.css';
import Home from "./Home"
function App() {
  return (
    <div className="App">
     <BrowserRouter>
    
       <Route exact path={"/"} component={Home}/>
    
     </BrowserRouter>
    </div>
  );
}

export default App;
