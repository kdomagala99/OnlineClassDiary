import styled from "styled-components";

const UsersList = () => {
  return (
    <List>
      <h3>Students:</h3>
      <ul>
        <li>Przemysław Wolski</li>
        <li>Janusz Kowalski</li>
        <li>Izabela Wróblewska</li>
        <li>Łukasz Broda</li>
        <li>Martin Squlimowski</li>
      </ul>
    </List>
  );
};

const List = styled.div`
  padding: 1rem;
  border-radius: 5px;
  width: 10%;
  position: absolute;
  top: 38%;
  left: 30%;
  right: 0;

  box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);

  h3 {
    text-align: center;
    color: rgb(240, 165, 68);
  }

  ul {
    margin: 1rem 0rem;
    list-style: none;
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
  }

  li {
    margin: 1rem 0;
    color: firebrick;
    font-weight: bold;
  }
`;

export default UsersList;
