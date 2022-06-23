import styled from "styled-components";

const SubjectsList = () => {
  return (
    <List>
      <h3>Subjects:</h3>
      <ul>
        <li>IT</li>
        <li>English</li>
        <li>Polish</li>
        <li>Mathematics</li>
        <li>Biology</li>
      </ul>
    </List>
  );
};

export default SubjectsList;

const List = styled.div`
  padding: 1rem;
  border-radius: 5px;
  width: 10%;
  position: absolute;
  top: 38%;
  right: 30%;

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
