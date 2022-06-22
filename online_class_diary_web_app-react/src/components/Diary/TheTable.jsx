import styled from "styled-components";
import Context from "../../store/context";
import { useContext } from "react";
import TableRow from "./TableRow";

const countAvg = (item) => {
  const avg = item.reduce((a, b) => a + b, 0) / item.length;
  if (avg) return avg;
};

const TheTable = () => {
  const ctx = useContext(Context);
  return (
    <Table>
      <thead>
        <tr>
          <th>Subject</th>
          <th colSpan={2}>Semester 1</th>
          <th colSpan={2}>Semester 2</th>
        </tr>
        <tr>
          <th></th>
          <th>Grades</th>
          <th>Avg. 1</th>
          <th>Grades</th>
          <th>Avg. 2</th>
        </tr>
      </thead>
      <tbody>
        {ctx.storedSubjects.map((item) => {
          return (
            <TableRow
              name={item.name}
              grades={item.grades.join(", ")}
              avg={countAvg(item.grades)}
            />
          );
        })}
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
