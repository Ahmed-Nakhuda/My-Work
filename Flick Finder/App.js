import React, { useState } from 'react';
import { Text, View, StyleSheet, TextInput, TouchableOpacity, Image, ScrollView } from 'react-native';


function App() {

  const [title, setTitle] = useState("");
  const [plot, setPlot] = useState("");
  const [year, setYear] = useState("");
  const [poster, setPoster] = useState("");
  const [genre, setGenre] = useState("");
  const [rating, setRating] = useState("");
  const [runtime, setRuntime] = useState("");
  const [season, setSeason] = useState("");
  const [episode, setEpisode] = useState("");


  async function getMovie() {
    try {
      const response = await fetch(`http://www.omdbapi.com/?t=${title}&y=${year}&apikey=f3530a5d`);
      const data = await response.json();
      setTitle(data.Title);
      setYear(data.Year);
      setPlot(data.Plot)
      setPoster(data.Poster)
      setGenre(data.Genre)
      setRating(data.imdbRating)
      setRuntime(data.Runtime)

    } catch (error) {
      console.error(error);
    }
  }


  async function getTVShow() {
    try {
      const response = await fetch(`http://www.omdbapi.com/?t=${title}&y=${year}&Season=${season}&Episode=${episode}&apikey=f3530a5d`);
      const data = await response.json();
      setTitle(data.Title);
      setPlot(data.Plot)
      setPoster(data.Poster)
      setRating(data.imdbRating)
      setRuntime(data.Runtime)
      setSeason(data.Season)
      setEpisode(data.Episode)

    } catch (error) {
      console.error(error);
    }
  }


  return (
    <ScrollView style={styles.parentContainer}>
      <Text style={styles.header}>Flick Finder</Text>
      <Text style={styles.slogan}>Find Your Next Favourite Movie or Show!</Text>

      <View style={styles.inputContainer}>
        <TextInput
          placeholder="Title"
          style={[styles.textInput, styles.titleInput]}
          onChangeText={setTitle}
        />
        <TextInput
          placeholder="Year (optional)"
          style={styles.textInput}
          onChangeText={setYear}
        />
      </View>

      <View style={styles.inputContainer}>
        <TextInput
          placeholder="Season"
          style={[styles.secondTextInput, styles.titleInput]}
          onChangeText={setSeason}
        />
        <TextInput
          placeholder="Episode"
          style={styles.secondTextInput}
          onChangeText={setEpisode}
        />
      </View>

      <View style={styles.buttonContainer}>
        <Text style={styles.moveLeft}></Text>
        <TouchableOpacity style={styles.button} onPress={getMovie}>
          <Text style={styles.buttonText}>Movie</Text>
        </TouchableOpacity>
        <TouchableOpacity style={[styles.button, styles.tvButton]} onPress={getTVShow}>
          <Text style={styles.buttonText}>TV</Text>
        </TouchableOpacity>
      </View>

      <View style={styles.movieContainer}>
        <Image style={styles.poster}
          source={{
            uri: poster
          }}
        />
        <Text style={[styles.movieInfo, styles.plot]}>
          {plot}
        </Text>
        <Text style={styles.movieInfo}>
          {genre}
        </Text>
        <Text style={styles.movieInfo}>
          {rating}
        </Text>
        <Text style={styles.movieInfo}>
          {runtime}
        </Text>
      </View>
    </ScrollView>
  );
};


const styles = StyleSheet.create({
  parentContainer: {
    backgroundColor: 'black',
  },
  header: {
    fontSize: 30,
    marginLeft: '35%',
    marginTop: '12%',
    fontWeight: 'bold',
    color: 'white',
  },
  slogan: {
    fontSize: 20,
    marginLeft: '8%',
    marginTop: '2%',
    color: 'white',
  },
  inputContainer: {
    display: 'flex',
    flexDirection: 'row',
  },
  textInput: {
    marginTop: '10%',
    borderWidth: 1,
    width: '40%',
    marginLeft: 12,
    padding: 10,
    borderColor: 'white',
    backgroundColor: 'white',
  },
  secondTextInput: {
    marginTop: '8%',
    borderWidth: 1,
    width: '40%',
    marginLeft: 12,
    padding: 10,
    borderColor: 'white',
    backgroundColor: 'white',
  },
  titleInput: {
    marginLeft: '10%',
  },
  buttonContainer: {
    display: 'flex',
    flexDirection: 'row',
    marginLeft: '10%',
  },
  button: {
    marginTop: '5%',
    backgroundColor: 'red',
    paddingTop: '4%',
    paddingBottom: '4%',
    paddingLeft: '8%',
    paddingRight: '8%',
    margin: '2%',
  },
  buttonText: {
    color: 'white',
    fontSize: 16,
  },
  tvButton: {
    paddingLeft: '11%',
    paddingRight: '11%',
  },
  moveLeft: {
    marginLeft: '12%',
  },
  movieContainer: {
    display: 'flex',
    marginTop: '10%',
    color: 'white',
  },
  poster: {
    width: 300,
    height: 450,
    marginLeft: '14%',
  },
  movieInfo: {
    fontSize: 18,
    marginLeft: '5%',
    marginTop: '2%',
    marginRight: '2%',
    color: 'white',
  },
  plot: {
    marginTop: '5%',
  },
});

export default App;
