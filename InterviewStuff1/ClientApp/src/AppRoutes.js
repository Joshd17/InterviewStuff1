import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { default as GetTemp } from "./components/GetTemp";
import { Home } from "./components/Home";

const AppRoutes = [
    {
        element: <GetTemp />,
        index: true,

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
        path: '/get-temp',
        element: <GetTemp />
    }
];

export default AppRoutes;
