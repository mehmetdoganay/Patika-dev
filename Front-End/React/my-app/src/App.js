import './App.css';
import Header from './components/Header'
import User from './components/User';


function App() {
  return (
    <div>
      <Header/>
      <User name="Mehmet" surname = "Doğanay" age={23} isLoggedIn = {true} />
    </div>
  )
}

export default App