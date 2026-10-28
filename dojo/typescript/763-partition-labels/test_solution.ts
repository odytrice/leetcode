import { finish, sequence, test } from "../shared.ts";
import { partitionLabels } from "./solution.ts";
import { partitionLabels as referencePartitionLabels } from "./reference_solution.ts";

const partitionLabelsImpl = process.argv.includes("--reference") ? referencePartitionLabels : partitionLabels;

test("example", () => sequence([9, 7, 8], partitionLabelsImpl("ababcbacadefegdehijhklij")));
test("one part", () => sequence([10], partitionLabelsImpl("eccbbbbdec")));
test("distinct", () => sequence([1, 1, 1], partitionLabelsImpl("abc")));

// Add your own cases here.

finish();
