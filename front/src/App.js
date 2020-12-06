import React, { Component } from 'react';
import './App.css';
import LikeButton from './components/LikeButton';

class App extends Component {

  state = {
    liked: false
  };

  render (){
    return(
    <div className="App">
      <LikeButton />     
    </div>
  )};
}

export default App;
