import FormContainer from "../UI/FormContainer";
import Context from "../../store/context";
import { apiService } from "../../services/api/api.service";
import { useContext, useRef } from "react";
const AddGrade = () => {
  const ctx = useContext(Context);
  const grade = useRef(null);
  const subject = useRef("");
  const surname = useRef("");
  const name = useRef("");
  const teacher = useRef("");

  const sendData = async (e) => {
    e.preventDefault();

    try {
      await apiService.addGrade(
        name.current.value,
        surname.current.value,
        subject.current.value,
        teacher.current.value,
        grade.current.value
      );
      ctx.gradeInfo("success");
      console.log(ctx.gradeStatus);
      ctx.reloadApp();
    } catch (err) {
      ctx.gradeInfo("failed");
      console.log(err);
    }
  };

  return (
    <FormContainer
      gradeStatus={ctx.gradeStatus}
      show={ctx.gradeForm}
      send={sendData}
    >
      <label htmlFor="name">Name: </label>
      <input type="text" id="name" ref={name} />
      <label htmlFor="surname">Surname: </label>
      <input type="text" id="surname" ref={surname} />
      <label htmlFor="subject">Subject: </label>
      <input type="text" id="subject" ref={subject} />
      <label htmlFor="teachersEmail">Teacher's Email: </label>
      <input type="text" id="teachersEmail" ref={teacher} />
      <label htmlFor="gradeValue">Value: </label>
      <input type="text" id="gradeValue" ref={grade} />
      <button type="submit">Add</button>

      {ctx.gradeStatus === "success" && <p>Grade added!</p>}
      {ctx.gradeStatus === "failed" && <p>Adding Failed!</p>}
    </FormContainer>
  );
};

export default AddGrade;
