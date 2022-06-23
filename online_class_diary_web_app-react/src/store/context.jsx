import { createContext, useState, useEffect } from "react";

import { apiService } from "../services/api/api.service";

const Context = createContext({
  footer: false,
  subjectForm: false,
  gradeForm: false,
  gradeStatus: "",
  storedSubjects: [],
  session: {},
  reloadApp: () => {},
  gradeInfo: () => {},
  footerVisibilityHandler: () => {},
  subjectFormVisibilityHandler: () => {},
  gradeFormVisibilityHandler: () => {},
});

export const ContextProvider = ({ children }) => {
  const [footer, setFooter] = useState(false);
  const [subjectForm, setSubjectForm] = useState(false);
  const [gradeForm, setGradeForm] = useState(false);
  const [storedSubjects, setStoredSubjects] = useState([]);
  const [send, setSend] = useState(false);
  const [session, setSession] = useState({});
  const [gradeStatus, setGradeStatus] = useState("");

  const userInfo = JSON.parse(sessionStorage.getItem("sessionObj"));

  useEffect(() => {
    const getData = async () => {
      try {
        const getSubjects = await apiService.getSubjects();
        const getGrades = await apiService.getGrades(
          userInfo.name,
          userInfo.surname
        );

        const tableRow = getSubjects.data.map((subject) => {
          const grades = getGrades.data[1].filter((item) => {
            return item.subject === subject.name;
          });
          return {
            name: subject.name,
            grades: grades.map((grade) => grade.value),
          };
        });

        setStoredSubjects(tableRow);
      } catch (err) {
        console.log(err);
      }
    };

    getData();
  }, [send]);

  const footerVisibilityHandler = () => {
    setFooter((previousState) => !previousState);
    setSubjectForm(false);
    setGradeForm(false);
  };

  const context = {
    gradeForm,
    gradeStatus,
    setGradeForm,
    session,
    setSession,
    footer,
    subjectForm,
    storedSubjects,
    footerVisibilityHandler,
    gradeInfo: (status) => setGradeStatus(status),
    reloadApp: () => setSend((previousState) => !previousState),
    subjectFormVisibilityHandler: () =>
      setSubjectForm((previousState) => !previousState),
    gradeFormVisibilityHandler: () =>
      setGradeForm((previousState) => !previousState),
  };

  return <Context.Provider value={context}>{children}</Context.Provider>;
};

export default Context;
