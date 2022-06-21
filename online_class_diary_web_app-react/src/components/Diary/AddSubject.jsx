import Context from "../../store/context";
import FormContainer from "../UI/FormContainer";
import { apiService } from "../../services/api/api.service";
import { useContext, useRef } from "react";

const AddSubject = () => {
  const ctx = useContext(Context);
  const subject = useRef("");
  // const firstSemesterGrades = useRef("");
  // const secondSemesterGrades = useRef("");

  const sendData = (e) => {
    e.preventDefault();
    ctx.setSend((prevState) => !prevState);
    apiService.addSubject(subject.current.value);
    console.log("test");
    // apiService.addGrades(firstSemesterGrades.current.value);
    // apiService.addGrades(secondSemesterGrades.current.value);
  };

  return (
    <FormContainer show={ctx.subjectForm} send={sendData}>
      <label htmlFor="subject">Subject Name: </label>
      <input type="text" id="subject" ref={subject} />
      {/* <label htmlFor="first-semester">First Semester Grades: </label>
      <input type="text" id="first-semester" ref={firstSemesterGrades} />
      <label htmlFor="second-semester">Second Semester Grades: </label>
      <input type="text" id="second-semester" ref={secondSemesterGrades} /> */}
      <button type="submit">Add</button>
    </FormContainer>
  );
};

export default AddSubject;
