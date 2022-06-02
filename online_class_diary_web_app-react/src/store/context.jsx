import { createContext, useState } from "react";

const Context = createContext({
  isVisible: false,
  footerVisibilityHandler: () => {},
});

export const ContextProvider = ({ children }) => {
  const [isVisible, setIsVisible] = useState(false);

  const footerVisibilityHandler = () => {
    setIsVisible((previousState) => !previousState);
    console.log(isVisible);
  };
  const context = {
    isVisible,
    footerVisibilityHandler,
  };

  return <Context.Provider value={context}>{children}</Context.Provider>;
};

export default Context;
