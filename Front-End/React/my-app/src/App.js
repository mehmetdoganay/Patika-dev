import './App.css';
import Header from './components/Header'
import User from './components/User';

const friends = [
  {
    id: 1,
    name: 'Burak',
  },
  {
    id: 2,
    name: 'Mehmet',
  },
  {
    id: 3,
    name: 'Ali',
  },
  {
    id: 4,
    name: 'Mahmut',
  },
  {
    id: 5,
    name: 'Osman',
  },
];

function App() {
  return (
    <div>
      <Header/>
      <User 
        name="Mehmet" 
        surname = "Doğanay" 
        age={23} 
        isLoggedIn = {true} 
        friends = {friends}
        />
    </div>
  )
}

export default App