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
    addSubject: (subjectName) =>
      axios.post(
        `${baseUrl}/subjectcontroller/createsubject`,
        {
          name: subjectName,
        },
        configAxios
      ),
    addGrade: (name, surname, subject, teacher, grade) =>
      axios.post(
        `${baseUrl}/Grade/addgradetostudent`,
        {
          name: name,
          surname: surname,
          value: grade,
          subject: subject,
          teacherEmail: teacher,
        },
        configAxios
      ),
    getGrades: (name, surname) =>
      axios.get(`${baseUrl}/Grade/studentgrades/${name}/${surname}`),
    checkLoginCredentials: (email, password) =>
      axios.post(
        `${baseUrl}/usercontroller/login`,
        { email, password },
        configAxios
      ),

    getUserInfo: (email) =>
      axios.get(`${baseUrl}/usercontroller/getuser/${email}`),
  };
};

export const apiService = api();
