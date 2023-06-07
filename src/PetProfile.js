import React from 'react';
import dogShadowImage from './vecteezy_shadow-cat-and-dog_.jpg'; // Assuming you have the dog shadow image file
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPen, faBatteryFull, faMapMarkerAlt } from '@fortawesome/free-solid-svg-icons';
import { useNavigate } from 'react-router-dom';


function PetProfile({ pet }) {
  const history = useNavigate();

  const handleEditClick = () => {
    console.log('Edit pet');
    // Logic to navigate to the AddPet component
    history.push('/addPet');
  };

  return (
    <div style={{ background: 'linear-gradient(to bottom, #83a4d4, #b6fbff)', padding: '20px', borderRadius: '10px', position: 'relative' }}>
      <FontAwesomeIcon
        icon={faBatteryFull}
        style={{ color: 'black', fontSize: '40px', position: 'absolute', top: '10px', left: '10px' }}
      />
      <FontAwesomeIcon
        icon={faMapMarkerAlt}
        style={{ color: 'black', fontSize: '40px', position: 'absolute', top: '10px', left: '60px' }}
      />
      <div style={{ textAlign: 'center' }}>
        <div
          style={{
            width: '250px',
            height: '280px',
            borderRadius: '50%',
            overflow: 'hidden',
            margin: '0 auto',
          }}
        >
          <img src={dogShadowImage} alt="Dog Shadow" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
        </div>
        <h2 style={{ color: 'black', marginTop: '20px' }}>
          {pet.name}
          <FontAwesomeIcon
            icon={faPen}
            style={{ color: 'black', cursor: 'pointer', marginLeft: '5px' }}
            onClick={handleEditClick}
          />
        </h2>
      </div>
      <div style={{ marginTop: '30px', display: 'flex', justifyContent: 'center' }}>
        <div
          style={{
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
            width: '100px',
            height: '100px',
            backgroundColor: 'lightblue',
            borderRadius: '10px',
            padding: '10px',
            margin: '10px',
          }}
        >
          <div style={{ width: '40px', height: '40px', borderRadius: '5px', marginBottom: '10px' }}></div>
          <h3 style={{ color: 'black' }}>Breed: {pet.breed}</h3>
        </div>
        <div
          style={{
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
            width: '100px',
            height: '100px',
            backgroundColor: 'lightblue',
            borderRadius: '10px',
            padding: '10px',
            margin: '10px',
          }}
        >
          <div style={{ width: '40px', height: '40px', borderRadius: '5px', marginBottom: '10px' }}></div>
          <h3 style={{ color: 'black' }}>Sex: {pet.sex}</h3>
        </div>
        <div
          style={{
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
            width: '100px',
            height: '100px',
            backgroundColor: 'lightblue',
            borderRadius: '10px',
            padding: '10px',
            margin: '10px',
          }}
        >
          <div style={{ width: '40px', height: '40px', borderRadius: '5px', marginBottom: '10px' }}></div>
          <h3 style={{ color: 'black' }}>Birthday: {pet.birthday}</h3>
        </div>
      </div>
      <div style={{ marginTop: '10px', display: 'flex', justifyContent: 'center' }}>
        <div
          style={{
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
            width: '100px',
            height: '100px',
            backgroundColor: 'lightblue',
            borderRadius: '10px',
            padding: '10px',
            margin: '10px',
          }}
        >
          <h3 style={{ color: 'black' }}>Height: {pet.height}</h3>
        </div>
        <div
          style={{
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
            width: '100px',
            height: '100px',
            backgroundColor: 'lightblue',
            borderRadius: '10px',
            padding: '10px',
            margin: '10px',
          }}
        >
          <h3 style={{ color: 'black' }}>Weight: {pet.weight}</h3>
        </div>
      </div>
    </div>
  );
}

export default PetProfile;
