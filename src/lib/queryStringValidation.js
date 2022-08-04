const isStringOnlyLetters = (stringToBeEvaluated) => /^[a-zA-Z]+$/.test(stringToBeEvaluated);

const isStringFiveLetters = (stringToBeEvaluated) => stringToBeEvaluated.length === 5;

const isQueryStringValid = (stringToBeEvaluated) => {
    console.log(stringToBeEvaluated);
    console.log(`String is only letters: ${isStringOnlyLetters(stringToBeEvaluated)}`);
    console.log(`String has a length of 5: ${isStringFiveLetters(stringToBeEvaluated)}`);
    return (isStringOnlyLetters(stringToBeEvaluated) === true && (isStringFiveLetters(stringToBeEvaluated) === true));
}

module.exports = {
    isQueryStringValid
};