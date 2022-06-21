import { createContext, useState, useEffect } from "react";

import { apiService } from "../services/api/api.service";

const Context = createContext({
  footer: false,
  subjectForm: false,
  storedSubjects: [],
  session: {},
  setTeacher: () => {},
  footerVisibilityHandler: () => {},
  subjectFormVisibilityHandler: () => {},
});

export const ContextProvider = ({ children }) => {
  const [footer, setFooter] = useState(false);
  const [subjectForm, setSubjectForm] = useState(false);
  const [storedSubjects, setStoredSubjects] = useState([]);
  const [send, setSend] = useState(false);
  const [session, setSession] = useState({});

  useEffect(() => {
    const getData = async () => {
      try {
        const getSubjects = await apiService.getSubjects();

        const tableRow = getSubjects.data.map((subject) => {
          return {
            name: subject.name,
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
  };

  const subjectFormVisibilityHandler = () => {
    setSubjectForm((previousState) => !previousState);
  };

  const context = {
    session,
    setSession,
    footer,
    subjectForm,
    storedSubjects,
    footerVisibilityHandler,
    subjectFormVisibilityHandler,
    setSend,
  };

  return <Context.Provider value={context}>{children}</Context.Provider>;
};

export default Context;
