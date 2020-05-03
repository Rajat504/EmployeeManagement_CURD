import React, { useState } from 'react';
import './App.css';
import axios from 'axios';

function App() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [loggedIn, setLoggedIn] = useState(false);

  const submit = (e) => {
    e.preventDefault();
    const data = { email, password };
    axios({
      method: 'post',
      url: 'http://employeecrud.azurewebsites.net/api/values/LoginEmployee/',
      data: data,
    })
      .then(function (response) {
        console.log(response);
        setLoggedIn(response.data);
      })
      .catch(function (error) {
        console.log(error);
      });
  };
  if (loggedIn) {
    return (
      <div>
        <h1>No Records Found!!</h1>
        <table border={1}>
          <tr>
            <td>First-Name</td>
            <td>rajat</td>
          </tr>
          <tr>
            <td>Last-Name</td>
            <td>ravindra</td>
          </tr>
          <tr>
            <td>Email</td>
            <td>rajat@gmail.com</td>
          </tr>
          <tr>
            <td>Age</td>
            <td>23</td>
          </tr>
          <tr>
            <td>Edit</td>
            <td>------</td>
          </tr>
          <tr>
            <td>delete</td>
            <td>#######</td>
          </tr>
        </table>
      </div>
    );
  }
  return (
    <div className='App'>
      <form onSubmit={submit}>
        <input
          type='text'
          value={email}
          onChange={(e) => {
            setEmail(e.target.value);
          }}
          placeholder='Enter email'
        />
        <br />
        <input
          type='text'
          value={password}
          onChange={(e) => {
            setPassword(e.target.value);
          }}
          placeholder='Enter password'
        />
        <br />
        <button type='Submit'>Submit</button>
      </form>
    </div>
  );
}

export default App;
