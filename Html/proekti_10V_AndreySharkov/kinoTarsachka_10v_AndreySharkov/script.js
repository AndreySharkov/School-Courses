const API_KEY = "7dad2698";
const searchInput = document.getElementById("searchInput");
const searchBtn = document.getElementById("searchBtn");
const resultsDiv = document.getElementById("results");
const favoritesDiv = document.getElementById("favorites");

let favoriteMovies = JSON.parse(localStorage.getItem("favorites")) || [];

function saveFavorites() {
  localStorage.setItem("favorites", JSON.stringify(favoriteMovies));
  displayFavorites();
}

function isInFavorites(id) {
  return favoriteMovies.some(movie => movie.id === id);
}

function displayFavorites() {
  favoritesDiv.innerHTML = "";
  favoriteMovies.forEach(movie => {
    const movieElement = document.createElement("div");
    movieElement.classList.add("movie");
    movieElement.innerHTML = `
      <img src="${movie.poster}" alt="${movie.title}">
      <h3>${movie.title}</h3>
      <button onclick="removeFromFavorites('${movie.id}')">Премахни</button>
    `;
    favoritesDiv.appendChild(movieElement);
  });
}

function addToFavorites(id, title, poster) {
  if (isInFavorites(id)) {
    alert("Филмът вече е в любими!");
    return;
  }

  favoriteMovies.push({ id, title, poster });
  saveFavorites();
}

function removeFromFavorites(id) {
  favoriteMovies = favoriteMovies.filter(movie => movie.id !== id);
  saveFavorites();
}

async function searchMovies() {
  const query = searchInput.value.trim();
  if (!query) {
    alert("Моля, въведете име на филм!");
    return;
  }

  const url = `https://www.omdbapi.com/?apikey=${API_KEY}&s=${query}`;

  try {
    const response = await fetch(url);
    const data = await response.json();

    if (data.Response === "True") {
      displaySearchResults(data.Search);
    } else {
      resultsDiv.innerHTML = `<p>Филмът не е намерен!</p>`;
    }
  } catch (error) {
    console.error("Грешка при заявката:", error);
    resultsDiv.innerHTML = `<p>Възникна грешка при търсенето.</p>`;
  }
}

function displaySearchResults(movies) {
  resultsDiv.innerHTML = "";
  movies.forEach(movie => {
    const movieElement = document.createElement("div");
    movieElement.classList.add("movie");
    movieElement.innerHTML = `
      <img src="${movie.Poster !== "N/A" ? movie.Poster : "https://via.placeholder.com/180x270"}" alt="${movie.Title}">
      <h3>${movie.Title} (${movie.Year})</h3>
      <button onclick="addToFavorites('${movie.imdbID}', '${movie.Title}', '${movie.Poster}')">Добави в любими</button>
    `;
    resultsDiv.appendChild(movieElement);
  });
}

searchBtn.addEventListener("click", searchMovies);
window.addEventListener("DOMContentLoaded", displayFavorites);
