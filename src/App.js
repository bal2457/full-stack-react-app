import React from 'react';
import './App.css';
import { NotesTable } from './components/NotesTables';

const App = () => {
  return (
    <div className="App"> 
      <h3>My Notes</h3>
      <div style={{mamxWidth: '70%', margin: 'auto'}}>
        <NotesTable/>
        </div>     
    </div>
  );
}

export default App;
