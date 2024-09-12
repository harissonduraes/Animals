import React from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { IAnimal } from './model'
import { Card, Cards, Habilidades } from './jss'

function App() {
  const [count, setCount] = React.useState(0)
  const [data, setData] = React.useState<IAnimal[]>()

  React.useEffect(() => {
    fetch("https://localhost:7282/api/cad-animal")
      .then((response) => (response.json()))
      .then((json) => setData(json))
  }, [])

  return (
    <>
      <Cards>

        {data && data.map((animal, index) => (
          <Card key={index}>
            <h2>
              {animal.nome}
            </h2>
            <img src={`src/assets/${animal.id}.jfif`} alt={animal.descricao} title={animal.descricao} />
            <p>
              {animal.descricao}
            </p>
            <Habilidades>
              {animal.habilidades.map((habilidades) => (
                <li title={habilidades.descricao}>{habilidades.nome}</li>
              ))}
            </Habilidades>
          </Card>
        ))}
      </Cards>
      <div>
        <a href="https://vitejs.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App
