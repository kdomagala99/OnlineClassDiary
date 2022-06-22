import Context from "../../store/context";
import FormContainer from "../UI/FormContainer";
import { apiService } from "../../services/api/api.service";
import { useContext, useRef } from "react";

const AddSubject = () => {
  const ctx = useContext(Context);
  const subject = useRef("");

  const sendData = async (e) => {
    e.preventDefault();

    try {
      await apiService.addSubject(subject.current.value);
      ctx.reloadApp();
    } catch (err) {
      console.log(err);
    }
  };

  return (
    <FormContainer show={ctx.subjectForm} send={sendData}>
      <label htmlFor="subject">Subject Name: </label>
      <input type="text" id="subject" ref={subject} />
      <button type="submit">Add</button>
    </FormContainer>
  );
};

export default AddSubject;
