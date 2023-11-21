import logo from "./logo.svg";
import "./App.css";
import Titulo from "./componentes/Titulo/Titulo";
import CardEvento from "./componentes/CardEvento/CardEvento";

function App() {
  return (
    <>
      <div>
        <Titulo texto="Hello, World" />
      </div>
      <div style={{display : "flex", justifyContent : "space-around"}}>
        {/* <CardEvento titulo="Evento de cria" descricao="um daqueles eventos, tá ligado?" desabilitado={true}/>
        <CardEvento titulo="Evento de cria" descricao="um daqueles eventos, tá ligado?" desabilitado={false}/>
        <CardEvento titulo="Evento de cria" descricao="um daqueles eventos, tá ligado?" desabilitado={true}/>
        <CardEvento titulo="Evento de cria" descricao="um daqueles eventos, tá ligado?" desabilitado={false}/> */}
      </div>
    </>
  );
}

export default App;