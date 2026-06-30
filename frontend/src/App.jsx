import { useState, useEffect } from 'react'
import './App.css'

function App() {
  const [games, setGames] = useState([])
  const [error, setError] = useState(null)

  useEffect(() => {
    // On appelle l'adresse de notre conteneur backend exposé sur le port 5000
    fetch('http://localhost:30001/api/games')
      .then(response => {
        if (!response.ok) throw new Error('Erreur réseau')
        return response.json()
      })
      .then(data => setGames(data))
      .catch(err => setError(err.message))
  }, [])

  return (
    <div className="App">
      <h1>🎮 GameHub 🎮</h1>
      <h2>Liste des Jeux détectés :</h2>
      
      {error && <p style={{ color: 'red' }}>Erreur : {error}</p>}
      
      <div className="card-container">
        {games.map(game => (
          <div key={game.id} className="card">
            <h3>{game.name}</h3>
            <p>Statut : <strong>{game.status}</strong></p>
          </div>
        ))}
      </div>
    </div>
  )
}

export default App