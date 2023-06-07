import React, { useState } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faBatteryFull, faMapMarkerAlt } from '@fortawesome/free-solid-svg-icons';
import { faDog } from '@fortawesome/free-solid-svg-icons/faDog'; // Importing the dog icon
import dogShadowImage from './vecteezy_shadow-cat-and-dog_.jpg'; 
import { useNavigate } from 'react-router-dom';


function AddPet() {
  const [name, setName] = useState('');
  const [breed, setBreed] = useState('');
  const [sex, setSex] = useState('');
  const [birthday, setBirthday] = useState('');
  const [height, setHeight] = useState('');
  const [weight, setWeight] = useState('');
  const [file, setFile] = useState(null);

  const handleNameChange = (event) => {
    setName(event.target.value);
  };

  const handleBreedChange = (event) => {
    setBreed(event.target.value);
  };

  const handleSexChange = (event) => {
    setSex(event.target.value);
  };

  const handleBirthdayChange = (event) => {
    setBirthday(event.target.value);
  };

  const handleHeightChange = (event) => {
    setHeight(event.target.value);
  };

  const handleWeightChange = (event) => {
    setWeight(event.target.value);
  };

  const handleFileChange = (event) => {
    setFile(event.target.files[0]);
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    // Perform the logic to add the pet (e.g., send an API request)
    console.log('Adding pet:', name, breed, sex, birthday, height, weight, file);
    // Reset the form
    setName('');
    setBreed('');
    setSex('');
    setBirthday('');
    setHeight('');
    setWeight('');
    setFile(null);
  };

  const history = useNavigate();

  const handleProfileClick = () => {
    console.log('Navigating to pet profile page');
    // Logic to navigate to the pet's profile page
    history.push('/petProfile');
  };

  return (
    <div style={{ background: 'linear-gradient(to bottom, #83a4d4, #b6fbff)', padding: '20px', borderRadius: '10px', textAlign: 'center' }}>
      <div
        style={{
          display: 'flex',
          justifyContent: 'space-between',
          alignItems: 'center',
          marginBottom: '20px',
          position: 'relative',
        }}
      >
        <div style={{ position: 'absolute', top: '0', left: '0', padding: '10px' }}>
          <FontAwesomeIcon icon={faBatteryFull} style={{ marginRight: '5px', fontSize: '40px' }} />
          <FontAwesomeIcon icon={faMapMarkerAlt} style={{ fontSize: '40px' }} />
        </div>
        <div style={{ position: 'absolute', top: '0', right: '0', padding: '10px', cursor: 'pointer' }}>
          <FontAwesomeIcon icon={faDog} style={{ fontSize: '40px' }} onClick={handleProfileClick} />
        </div>
      </div>
      <div
        style={{
          width: '250px',
          height: '280px',
          borderRadius: '50%',
          overflow: 'hidden',
          margin: '0 auto',
        }}
      >
        <label htmlFor="upload-input">
          <input
            id="upload-input"
            type="file"
            style={{ display: 'none' }}
            onChange={handleFileChange}
            accept="image/*"
          />
          <img
            src={dogShadowImage}
            alt="Dog Shadow"
            style={{ width: '100%', height: '80%', objectFit: 'cover', cursor: 'pointer' }}
          />
        </label>
      </div>
      <form onSubmit={handleSubmit} style={{ marginTop: '-13px' }}>
        <h2
          style={{
            color: 'black',
            fontWeight: 'bold',
            fontSize: '24px',
            marginBottom: '20px',
            marginTop: '0',
          }}
        >
          Add New Pet
        </h2>
        <input
          type="text"
          value={name}
          onChange={handleNameChange}
          style={{
            borderRadius: '10px',
            padding: '5px',
            marginBottom: '10px',
            display: 'block',
            width: '250px',
            height: '20px',
            margin: '0 auto',
          }}
          placeholder="Name"
        />
        <br />
        <input
          type="text"
          value={breed}
          onChange={handleBreedChange}
          style={{
            borderRadius: '10px',
            padding: '5px',
            marginBottom: '10px',
            display: 'block',
            width: '250px',
            height: '20px',
            margin: '0 auto',
          }}
          placeholder="Breed"
        />
        <br />
        <input
          type="text"
          value={sex}
          onChange={handleSexChange}
          style={{
            borderRadius: '10px',
            padding: '5px',
            marginBottom: '10px',
            display: 'block',
            width: '250px',
            height: '20px',
            margin: '0 auto',
          }}
          placeholder="Sex"
        />
        <br />
        <input
          type="text"
          value={birthday}
          onChange={handleBirthdayChange}
          style={{
            borderRadius: '10px',
            padding: '5px',
            marginBottom: '10px',
            display: 'block',
            width: '250px',
            height: '20px',
            margin: '0 auto',
          }}
          placeholder="Birthday"
        />
        <br />
        <input
          type="text"
          value={height}
          onChange={handleHeightChange}
          style={{
            borderRadius: '10px',
            padding: '5px',
            marginBottom: '10px',
            display: 'block',
            width: '250px',
            height: '20px',
            margin: '0 auto',
          }}
          placeholder="Height"
        />
        <br />
        <input
          type="text"
          value={weight}
          onChange={handleWeightChange}
          style={{
            borderRadius: '10px',
            padding: '5px',
            marginBottom: '10px',
            display: 'block',
            width: '250px',
            height: '20px',
            margin: '0 auto',
          }}
          placeholder="Weight"
        />
        <br />
        <button
          type="submit"
          style={{
            marginTop: '10px',
            backgroundColor: 'blue',
            color: 'white',
            padding: '8px 16px',
            borderRadius: '5px',
            border: 'none',
            fontWeight: 'bold',
          }}
        >
          Save
        </button>
      </form>
    </div>
  );
}

export default AddPet;
