# QuestionLearner
app that helps you memorize a set of question with their answer

XML file example:
<?xml version="1.0"?>
<questionnaire>
	<questions>
		<text>this question</text>
		<answer>true</answer>
	</questions>
	<questions>
		<text resource="1">this question</text>
		<answer>true</answer>
	</questions>
	<resources>
		<resource id="1">./images/img1.jpg</resource>
	</resources>
</questionnaire>