import logo from "./logo.svg";
import "./App.css";
import Titulo from "./componentes/Titulo/Titulo";
import CardEvento from "./componentes/CardEvento/CardEvento";

function App() {
  return (
    <>
      <div>
        <Titulo texto="Richard" />
      </div>
      <div style={{display : "flex", justifyContent : "space-around"}}>
        <CardEvento titulo="Evento de cria" descricao="um daqueles eventos, tá ligado?" disabilitado={true}/>
      </div>
    </>
  );
}

export default App;