import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { default as GetTemp } from "./components/GetTemp";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  },
    {
      index: true,
      path: '/get-temp',
      element: <GetTemp />
  }
];

export default AppRoutes;
