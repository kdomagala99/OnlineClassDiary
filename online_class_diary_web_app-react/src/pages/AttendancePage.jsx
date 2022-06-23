import styled from "styled-components";

const AttendancePage = () => {
  return (
    <>
      <Table>
        <thead>
          <tr>
            <th colSpan={5}>Attendance</th>
          </tr>
          <tr>
            <th></th>
            <th>IT</th>
            <th>Biology</th>
            <th>Polish</th>
            <th>Mathematics</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>Przemysław Wolski</td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
          </tr>
          <tr>
            <td>Janusz Kowalski</td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
          </tr>
          <tr>
            <td>Izabela Wróblewska</td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
          </tr>

          <tr>
            <td>Łukasz Broda</td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
          </tr>
          <tr>
            <td>Martin Squlimowski</td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
            <td>
              <input type="checkbox" />
            </td>
          </tr>
        </tbody>
      </Table>
      <Button>Save</Button>
    </>
  );
};

export default AttendancePage;

const Table = styled.table`
  margin-top: 20rem;
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

  thead > tr:nth-of-type(1) th {
    font-size: 1.4rem;
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

const Button = styled.button`
  padding: 0.7rem 0.7rem;
  margin-top: 2rem;
  width: 7rem;
  margin: 6rem auto;
  outline: none;
  border: none;
  border-radius: 5px;
  color: white;
  font-weight: bold;
  background-color: rgb(233, 186, 125);
  cursor: pointer;
`;
