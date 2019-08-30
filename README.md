# QuestionLearner
app that helps you memorize a set of question with their answer

XML file example:
<?xml version="1.0"?>
<questionnaire>
	<questions>
		<question>
			<text>this question</text>
			<answer>true</answer>
			<resource>null</resource>
		</question>
		<question>
			<text>this question</text>
			<answer>false</answer>
			<resource>1</resource>
		</question>
	</questions>
	<resources>
		<resource id="1">./images/img1.jpg</resource>
	</resources>
</questionnaire>