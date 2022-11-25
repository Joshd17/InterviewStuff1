import React, { useState, useEffect } from 'react';

function isNumber(n) {
    return typeof n == 'number' && !isNaN(n) && isFinite(n);
}

function GetTemp() {
    const displayData = [
        { C: 0, F: 32 },
        { C: 10, F: 50 },
        { C: 20, F: 68 },
        { C: 30, F: 86 },
        { C: 40, F: 104 }
    ]

    const [displayValues, setDisplayValues] = useState({
        cDisplay: "",
        fDisplay: ""
    });
    const [values, setValues] = useState({
        celcius: "",
        farenheit: "",
    });

    const getTempValues = async () => {
        const floatF = parseFloat(values.farenheit);
        if (isNumber(floatF)) {
            const f = await fetch('temperature?type=0&value=' + floatF);
            setDisplayValues({ ...displayValues, fDisplay: await f.json() });
        }

        const floatC = parseFloat(values.celcius);
        if (isNumber(floatC)) {
            const c = await fetch('temperature?type=1&value=' + floatC);
            setDisplayValues({ ...displayValues, cDisplay: await c.json() });
        }
    }
    useEffect(() => {
        getTempValues();
    }, [values.celcius, values.farenheit]);

    const handleCChange = (event) => {
        setValues({ ...values, celcius: event.target.value });
    }

    const handleFChange = (event) => {
        setValues({ ...values, farenheit: event.target.value });
    }

    return (
        <div>
            <form>
                <h3>Input Celcius</h3>
                <input
                    type="text"
                    value={values.celcius}
                    onChange={handleCChange}
                />
                <p>{displayValues.cDisplay} F</p>

                <h3>Input F</h3>
                <input
                    type="text"
                    value={values.farenheit}
                    onChange={handleFChange}
                />
                <p>{displayValues.fDisplay} C</p>

                <table className="table table-striped" >
                    <tr>
                        <th>C</th>
                        <th>F</th>
                    </tr>
                    {displayData.map((val, key) => {
                        return (
                            <tr key={key}>
                                <td>{val.C}</td>
                                <td>  {val.F}</td>
                            </tr>
                        )
                    })}
                </table>
            </form>
        </div>
    );

};


export default GetTemp;
