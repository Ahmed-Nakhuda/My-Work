import '../App.css';
import React, { useState, useEffect } from 'react';
import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';
import DeleteIcon from '@mui/icons-material/Delete';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';

function Inventory() {
   // isLoaded keeps track of whether the initial load of pet data from the server has occurred. 
   const [isLoaded, setIsLoaded] = useState(false);

   // pets is the array of pets data in the table
   const [pets, setPets] = useState([]);
 
   // use states for the input boxes
   const [animal, setAnimalValue] = useState('');
   const [description, setDescriptionValue] = useState('');
   const [age, setAgeValue] = useState('');
   const [price, setPriceValue] = useState('');
 
 
   // update the use states
   const handleAnimalChange = (event) => {
     setAnimalValue(event.target.value);
   }
 
   const handleDescriptionChange = (event) => {
     setDescriptionValue(event.target.value);
   }
 
   const handleAgeChange = (event) => {
     setAgeValue(event.target.value);
   }
 
   const handlePriceChange = (event) => {
     setPriceValue(event.target.value);
   }
 
 
   // fetches all pet data from the server
   function fetchPets() {
     fetch("http://localhost:3001/api?act=getall")
       .then(res => res.json())
       .then(
         (result) => {
           setIsLoaded(true);
           setPets(result);
         })
   }
 
   // only be called when the component first mounts
   useEffect(fetchPets, []);
 
 
   /**
    * Function to add a pet
    */
   function addPet() {
     fetch("http://localhost:3001/api?act=add&animal=" + animal + "&description=" + description + "&age=" + age + "&price=" + price)
       .then(res => res.json())
       .then(
         (result) => {
           fetchPets();
         })
   }
 
 
   /**
    * Function to delete a pet
    * @param id the id of the pet to delete 
    */
   function deletePet(id) {
     fetch("http://localhost:3001/api?act=delete&id=" + id)
       .then(res => res.json())
       .then(
         (result) => {
           fetchPets();
         })
   }
 
 
   /**
    * Function to update a pet
    * @param id the id of the pet to update 
    */
   function updatePet(id) {
     fetch("http://localhost:3001/api?act=update&id=" + id + "&animal=" + animal + "&description=" + description + "&age=" + age + "&price=" + price)
       .then(res => res.json())
       .then(
         (result) => {
           fetchPets();
         });
   }

  if (!isLoaded) {
    return <div>Loading...</div>;
  } else {
    return (
      <div>
        <h1>Inventory</h1>
        <TableContainer style={{ width: '50%', margin: '0 auto' }}>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>ID</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Animal</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Description</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Age</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Price</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Delete</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Update</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {pets.map((pet) => (
                <TableRow
                  key={pet.id}
                >
                  <TableCell component="th" scope="row" style={{fontSize: "18px"}} >
                    {pet.id}
                  </TableCell>
                  <TableCell align="center" className="table-header-cell" style={{fontSize: "18px"}}>{pet.animal}</TableCell>
                  <TableCell align="center" style={{fontSize: "18px"}}>{pet.description}</TableCell>
                  <TableCell align="center" style={{fontSize: "18px"}}>{pet.age}</TableCell>
                  <TableCell align="center" style={{fontSize: "18px"}}>{"$" + pet.price}</TableCell>
                  <TableCell align="center" style={{fontSize: "18px"}}><Button variant="contained" startIcon={<DeleteIcon />} onClick={() => deletePet(pet.id)}>Delete</Button></TableCell>
                  <TableCell align="center" style={{fontSize: "18px"}}><Button variant="contained" onClick={() => updatePet(pet.id)}>Update</Button>
                  </TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
        <br />
        <div id="inputContainer">
          <TextField
            id="animalInput"
            label="Animal"
            variant="outlined"
            onChange={handleAnimalChange}
            style={{ marginRight: '5px' }}
          />

          <TextField
            id="descriptionInput"
            label="Description"
            variant="outlined"
            onChange={handleDescriptionChange}
            style={{ marginRight: '5px' }}
          />

          <TextField
            id="ageInput"
            label="Age"
            variant="outlined"
            type="number"
            onChange={handleAgeChange}
            style={{ marginRight: '5px' }}
          />

          <TextField
            id="priceInput"
            label="Price"
            variant="outlined"
            type="number"
            onChange={handlePriceChange}
          />
        </div>
        <br />
        <Button id="addPetButton" variant="contained" onClick={addPet}>Add Pet</Button>
      </div>
    );
  }
}

export default Inventory;
