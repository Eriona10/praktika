import React from 'react';
import AddPet from './AddPet';
import PetProfile from './PetProfile';
import PaymentPage from './PaymentPage'; 
import './App.css'; 
// import { BrowserRouter as Router, Route } from 'react-router-dom';


function App() {
  // Assuming you have the pet data
  const pet = {
    name: 'Max',
    breed: 'Labrador Retriever',
    sex: 'Male',
    birthday: 'June 1, 2018',
    height: '60 cm',
    weight: '30 kg',
  };

  return (
    <div className="App">
      <h1>Add Pet</h1>
      <AddPet />

      <h1>Pet Profile</h1>
      <PetProfile pet={pet} />

      <h1>PaymentPage</h1>
      <PaymentPage />
    </div>
  );
}

export default App;
