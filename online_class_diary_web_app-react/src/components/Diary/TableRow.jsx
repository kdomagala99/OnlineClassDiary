const TableRow = ({ name, grades, avg }) => {
  return (
    <tr>
      <td>{name}</td>
      <td></td>
      <td></td>
      <td>{grades}</td>
      <td>{avg}</td>
    </tr>
  );
};

export default TableRow;
