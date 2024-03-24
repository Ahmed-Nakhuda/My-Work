/* "StAuth10244: I Ahmed Nakhuda, 000878456 certify that this material is my original work. No
other person's work has been used without due acknowledgement. I have not made
my work available to anyone else."
*/

import '../App.css';
import React, { useState, useEffect } from 'react';
import TextField from '@mui/material/TextField';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';


function Search() {
  // isLoaded keeps track of whether the initial load of pet data from the server has occurred. 
  const [isLoaded, setIsLoaded] = useState(false);
  
  // searchResults is the array of pets data in the table
  const [searchResults, setSearchResults] = useState([]);

  // search input box useState
  const [searchString, setSearchStringValue] = useState('');
  

  // update the use state
  const handleSearchStringChange = (event) => {
    setSearchStringValue(event.target.value);
  }


/**
 * Function to search for a pet
 */
  function searchPet() {
    fetch("http://localhost:3001/api?act=search&term=" + searchString)
      .then(res => res.json())
      .then(
        (result) => {
          setIsLoaded(true);
          setSearchResults(result);
        });
  }


  // runs on mount and when searchString changes
  useEffect(searchPet, [searchString]);


  if (!isLoaded) {
    return <div>Loading...</div>;
  } else {
    return (
      <div>
        <h1>Search</h1>
        <div id="searchInput">
          <TextField
            label="Search"
            variant="outlined"
            type="text"
            onChange={handleSearchStringChange}
          />
          </div>
          <TableContainer style={{ width: '50%', margin: '0 auto' }}>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>ID</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Animal</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Description</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Age</TableCell>
                <TableCell align="center" style={{ fontWeight: "bold", fontSize: "18px" }}>Price</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {searchResults.map((pet) => (
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
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
      </div>
    );
  }
}

export default Search;
