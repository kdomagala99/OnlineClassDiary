import axios from "axios";

const api = () => {
  const baseUrl = "https://localhost:5001/api";
  let configAxios = {
    headers: {
      "Content-Type": "multipart/form-data",
    },
  };

  return {
    getSubjects: () => axios.get(`${baseUrl}/subjectcontroller/getsubjects`),
    // getGrades: () => axios.get(`${baseUrl}/gradecontroller/getgrade`),
    addSubject: (subjectName) =>
      axios.post(
        `${baseUrl}/subjectcontroller/createsubject`,
        {
          name: subjectName,
        },
        configAxios
      ),
    // addGrades: (grades) =>
    //   axios.post(
    //     `${baseUrl}/gradecontroller/creategrade`,
    //     {
    //       name: grades,
    //     },
    //     configAxios
    //   ),

    getUsers: (email, password) =>
      axios.post(
        `${baseUrl}/usercontroller/login`,
        { email, password },
        configAxios
      ),
  };
};

export const apiService = api();
