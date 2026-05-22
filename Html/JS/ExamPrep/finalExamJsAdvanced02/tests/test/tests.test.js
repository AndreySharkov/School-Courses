import { expect } from "chai";
import { findNumber } from "../task.js";

describe("findNumber tests", () => {
    it("valid input", () => {
        expect(findNumber([1234, 246, 1111])).to.equal(246);
    });
    it("Empty array", () => {
        expect(findNumber([])).to.equal(0);
    });

    it("No even numbers", () => {
        expect(findNumber([135, 79])).to.equal(0);
    });

    it("Single number in array", () => {
        expect(findNumber([246])).to.equal(246);
    });
    it("Should not work with a number not in array", () => {
        expect(findNumber(234)).to.equal(0);
    });
    
    it("String in Input", () => {
        expect(findNumber("string")).to.equal(0);
    });
    it("Should not parse ascii characters", () => {
        expect(findNumber(['23', 'rg', 'BBBBB'])).to.equal('23');
    });

    it("Should work with negative numbers", () => {
        expect(findNumber([-2, -44])).to.equal(-44);
    });

    it("Should work with decimal numbers", () => {
        expect(findNumber([2.2, 4.44])).to.equal(4.44);
    });

    it("Should work with zero value", () => {
        expect(findNumber([0])).to.equal(0);
    });

    it("Should cras if no input", () => {
        expect(() => findNumber()).to.throw(TypeError);
    });
    it("Should throw error when undefined is passed", () => {
        expect(() => findNumber(undefined)).to.throw(TypeError);
    });
    it("Undefined, Null and NaN values in input", () => {
        expect(() => findNumber([null, undefined, NaN])).to.throw(TypeError);
    });
    it("Overflowing Number Not keeping actual Value", () => {
        expect(findNumber([999999999999999999999999999999999999999999999999999999999999999999999999999999900000000000000000000000000000000001000000000000001])).to.equal(1e+129);
    });
});
