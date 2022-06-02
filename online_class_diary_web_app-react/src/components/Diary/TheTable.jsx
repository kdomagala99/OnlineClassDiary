import styled from "styled-components";

const TheTable = () => {
  return (
    <Table>
      <thead>
        <tr>
          <th>Subject</th>
          <th colSpan={3}>Semester 1</th>
          <th colSpan={3}>Semester 2</th>
        </tr>
        <tr>
          <th></th>
          <th>Grades</th>
          <th>Avg. 1</th>
          <th>Final</th>
          <th>Grades</th>
          <th>Avg. 2</th>
          <th>Final</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>1</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
        </tr>
        <tr>
          <td>2</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
        </tr>
        <tr>
          <td>3</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
          <td>test</td>
        </tr>
      </tbody>
    </Table>
  );
};

const Table = styled.table`
  margin-top: 12rem;
  margin-left: auto;
  margin-right: auto;
  border-collapse: collapse;
  font-size: 0.9em;
  width: 60%;
  border-radius: 5px 5px 0 0;
  overflow: hidden;
  box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);
  text-align: center;

  thead > tr:nth-of-type(1) {
    color: rgb(240, 165, 68);
  }

  thead > tr:nth-of-type(1) th:nth-child(2) {
    border-left: 2px solid rgb(233, 186, 125);
    border-right: 2px solid rgb(233, 186, 125);
  }

  thead > tr:nth-of-type(2) {
    background-color: rgb(233, 186, 125);
    color: rgb(255, 255, 255);
    font-weight: bold;
  }

  th,
  td {
    padding: 12px 15px;
  }

  tbody tr:nth-of-type(even) {
    background-color: rgb(243, 243, 243);
  }

  tbody tr:last-of-type {
    border-bottom: 2px solid rgb(233, 186, 125);
  }
`;

export default TheTable;
