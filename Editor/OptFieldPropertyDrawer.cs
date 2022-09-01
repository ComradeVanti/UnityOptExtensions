using Dev.ComradeVanti.RectConstraints;
using UnityEditor;
using UnityEngine;

namespace Dev.ComradeVanti.OptUnity
{

    [CustomPropertyDrawer(typeof(OptField<>))]
    public class OptFieldPropertyDrawer : PropertyDrawer
    {

        private const float ButtonWidth = 50;


        private static SerializedProperty GetArrayProp(SerializedProperty fieldProp) =>
            fieldProp.FindPropertyRelative("arr");

        private static SerializedProperty GetOptValueProp(SerializedProperty fieldProp) =>
            GetArrayProp(fieldProp).GetArrayElementAtIndex(0);

        private static bool IsSome(SerializedProperty fieldProp) =>
            GetArrayProp(fieldProp).arraySize == 1;

        private static void MakeNone(SerializedProperty fieldProp)
        {
            var arrayProp = GetArrayProp(fieldProp);
            arrayProp.arraySize = 0;
        }

        private static void MakeSome(SerializedProperty fieldProp)
        {
            var arrayProp = GetArrayProp(fieldProp);
            arrayProp.arraySize = 1;
        }

        private static void SwitchNoneSome(SerializedProperty fieldProp)
        {
            var isSome = IsSome(fieldProp);

            if (isSome)
                MakeNone(fieldProp);
            else
                MakeSome(fieldProp);
        }


        /// <inheritdoc />
        public override float GetPropertyHeight(SerializedProperty fieldProp, GUIContent label) =>
            IsSome(fieldProp)
                ? EditorGUI.GetPropertyHeight(GetOptValueProp(fieldProp))
                : EditorGUIUtility.singleLineHeight;

        /// <inheritdoc />
        public override void OnGUI(Rect container, SerializedProperty fieldProp, GUIContent label)
        {
            var labelRect = Constrain.Rectangle(
                top: Constrain.toTop.Of(container),
                left: Constrain.toLeft.Of(container),
                width: Constrain.ToSize(EditorGUIUtility.labelWidth),
                height: Constrain.ToSize(EditorGUIUtility.singleLineHeight)
            );
            var buttonRect = Constrain.Rectangle(
                top: Constrain.toTop.Of(container),
                left: Constrain.toRight.Of(labelRect),
                width: Constrain.ToSize(ButtonWidth),
                height: Constrain.ToSize(EditorGUIUtility.singleLineHeight)
            );
            var valueRect = Constrain.Rectangle(
                top: Constrain.toTop.Of(container),
                left: Constrain.toRight.Of(buttonRect).WithOffset(10),
                right: Constrain.toRight.Of(container),
                bottom: Constrain.toBottom.Of(container)
            );
            var buttonLabel = IsSome(fieldProp) ? "Some" : "None";


            EditorGUI.LabelField(labelRect, label);

            if (GUI.Button(buttonRect, buttonLabel))
                SwitchNoneSome(fieldProp);

            if (IsSome(fieldProp))
                EditorGUI.PropertyField(valueRect, GetOptValueProp(fieldProp),
                                        GUIContent.none, true);
        }

    }

}