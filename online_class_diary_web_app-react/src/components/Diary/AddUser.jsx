import styled from "styled-components";
import { apiService } from "../../services/api/api.service";
import { useRef } from "react";

const AddUser = () => {
  const email = useRef("");
  const password = useRef("");
  const name = useRef("");
  const surname = useRef("");
  const role = useRef("");

  const submitHandler = async (e) => {
    e.preventDefault();

    try {
      await apiService.addUser(
        email.current.value,
        password.current.value,
        name.current.value,
        surname.current.value,
        role.current.value
      );

      email.current.value = "";
      password.current.value = "";
      name.current.value = "";
      surname.current.value = "";
      role.current.value = "";
    } catch (err) {
      console.log(err);
    }
  };

  return (
    <Form onSubmit={submitHandler}>
      <h1>Add User</h1>
      <div>
        <label htmlFor="email">E-mail:</label>
        <input type="email" id="email" ref={email} />
      </div>
      <div>
        <label htmlFor="password">Password:</label>
        <input type="password" id="password" ref={password} />
      </div>
      <div>
        <label htmlFor="name">Name:</label>
        <input type="text" id="name" ref={name} />
      </div>
      <div>
        <label htmlFor="surname">Surname:</label>
        <input type="text" id="surname" ref={surname} />
      </div>
      <div>
        <label htmlFor="role">Role:</label>
        <input type="text" id="role" ref={role} />
      </div>
      <button>Add</button>
    </Form>
  );
};

const Form = styled.form`
  position: absolute;
  top: 35%;
  right: 0;
  left: 0;
  margin: 0 auto;
  width: 20%;
  display: flex;
  align-items: flex-start;
  flex-direction: column;
  padding: 1rem;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.26);
  border-radius: 5px;

  h1 {
    margin: 0 auto;
    color: rgb(240, 165, 68);
  }
  label {
    width: 10rem;
    color: rgb(240, 165, 68);
    font-weight: bold;
  }

  div {
    width: 75%;
    display: flex;
    justify-content: space-between;

    margin: 1rem 0rem;
  }

  h1 {
    text-align: center;
    padding: 1rem;
  }

  input {
    outline: none;
    border: none;
    border: 1px solid rgb(231, 186, 126);
    padding: 0.2rem;
  }

  button {
    margin: 1rem auto;
    padding: 0.3rem 2rem;
    background-color: rgb(240, 165, 68);
    border: none;
    color: rgb(255, 255, 255);
    cursor: pointer;
  }
`;

export default AddUser;
